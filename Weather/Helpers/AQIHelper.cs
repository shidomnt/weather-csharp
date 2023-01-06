﻿using Newtonsoft.Json;
using Weather.Classes;
using Weather.Constants;

namespace Weather.Helpers
{
    internal static class AQIHelper
    {
        //concentration: nong do μg/m3
        public static int CalculateAirQuality(float concentration, PollutantGas pollutantGas)
        {
            var roundedConcentration = pollutantGas switch
            {
                PollutantGas.Pm25 or PollutantGas.Co => Math.Round(concentration, 1),
                PollutantGas.O3 => Math.Round(concentration, 3),
                _ => Math.Round(concentration),
            };

            var finalConcentration = pollutantGas switch
            {
                PollutantGas.O3 => ToPPM(roundedConcentration, MolecularWeight.O3),
                PollutantGas.Co => ToPPM(roundedConcentration, MolecularWeight.Co),
                PollutantGas.No2 => ToPPB(roundedConcentration, MolecularWeight.No2),
                PollutantGas.So2 => ToPPB(roundedConcentration, MolecularWeight.So2),
                _ => roundedConcentration,
            };

            var aqiBreakpoints = JsonConvert
                .DeserializeObject<AQIBreakpoints>(
                System.Text.Encoding.UTF8.GetString(Properties.Resources.AQIBreakpoints));

            var propBreakpoint = typeof(AQIBreakpoints)
                .GetProperties()
                .FirstOrDefault(prop => prop.Name.Contains(pollutantGas.ToString()));

            var valueBreakpoint = propBreakpoint?.GetValue(aqiBreakpoints);

            var propRange = propBreakpoint?.PropertyType
                .GetProperties()
                .FirstOrDefault(prop =>
                {
                    var value = prop.GetValue(valueBreakpoint);
                    if (value is null) return false;
                    var (min, max) = ExtractBreakpointValue(value?.ToString()!);
                    return finalConcentration >= min && finalConcentration <= max;
                });

            var valueRange = ExtractBreakpointValue(propRange?.GetValue(valueBreakpoint)?.ToString()!);
            var aqiRange = ExtractBreakpointValue(propRange?.GetValue(aqiBreakpoints?.AQI)?.ToString()!);

            var result =
                ((aqiRange.max - aqiRange.min) / (valueRange.max - valueRange.min)) *
                (finalConcentration - valueRange.min) + aqiRange.min;

            return Convert.ToInt32(result);
        }

        public static (double min, double max) ExtractBreakpointValue(string breakpointValue)
        {
            var result = breakpointValue.Split(" - ")
                .Select(number => Convert.ToDouble(number))
                .ToArray();
            return (min: result[0], max: result[1]);
        }

        //concentration: nong do μg/m3
        public static double ToPPB(double concentration, float molecularWeight)
        {
            return 24.45 * concentration / molecularWeight;
        }

        public static double ToPPM(double concentration, float molecularWeight)
        {
            return ToPPB(concentration, molecularWeight) / 1000;
        }
    }
}
