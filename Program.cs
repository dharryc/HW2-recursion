using tests;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<MyBenchmark>();

[MinWarmupCount(3), MaxWarmupCount(5)]
[MinIterationCount(3), MaxIterationCount(5)]
public class MyBenchmark
{
    [Params(23, 24, 25, 26, 27, 28, 29, 30)]
    public int Exponent { get; set; }

    // [Params(5)]
    // public int Base { get; set; }

    [Benchmark]
    public int ipowerOf2() => Algorithms.iterativePowerOf2(Exponent);

    [Benchmark(Baseline = true)]
    public int fastpowerOf2() => Algorithms.fastPowerOf2(Exponent);

    [Benchmark]
    public int superPowerOf2() => Algorithms.superAlgorithm(Exponent);
}