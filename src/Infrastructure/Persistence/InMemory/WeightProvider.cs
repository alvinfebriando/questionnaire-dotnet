﻿using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Infrastructure.Persistence.InMemory;

public class WeightProvider: IWeightProvider
{
    public Dictionary<int, double[]> Weight { get; set; } = new()
    {
        { 1, new double[] { 0.75, 0.1, 0.075, 0.05, 0.025 } },
        { 2, new double[] { 0.1, 0.75, 0.075, 0.05, 0.025 } },
        { 3, new double[] { 0.025, 0.05, 0.75, 0.1, 0.075 } },
        { 4, new double[] { 0.025, 0.05, 0.075, 0.75, 0.1 } },
        { 5, new double[] { 0.025, 0.05, 0.075, 0.1, 0.75 } }
    };
}