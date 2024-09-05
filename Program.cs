using tests;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<MyBenchmark>();

[MinWarmupCount(3), MaxWarmupCount(5)]
[MinIterationCount(3), MaxIterationCount(5)]
public class MyBenchmark
{
    [Params(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 32, 64, 250, 1000, 1500, 2000)]
    public int Exponent { get; set; }

    [Params(5)]
    public int Base { get; set; }

    [Benchmark]
    public int ipowerOf2() => Algorithms.iterativePowerOf2(Exponent);

    [Benchmark(Baseline = true)]
    public int PowerOf2() => Algorithms.recursivePowerOf2(Exponent);
}