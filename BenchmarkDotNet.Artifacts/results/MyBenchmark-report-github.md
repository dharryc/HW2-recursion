```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4037/23H2/2023Update/SunValley3)
AMD Ryzen 7 PRO 6850U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-FKXDDB : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

MaxIterationCount=5  MaxWarmupIterationCount=5  MinIterationCount=3  
MinWarmupIterationCount=3  

```
| Method        | Exponent | Mean      | Error     | StdDev    | Ratio | RatioSD |
|-------------- |--------- |----------:|----------:|----------:|------:|--------:|
| **ipowerOf2**     | **23**       |  **5.159 ns** | **0.0681 ns** | **0.0177 ns** |  **0.73** |    **0.00** |
| fastpowerOf2  | 23       |  7.045 ns | 0.1534 ns | 0.0084 ns |  1.00 |    0.00 |
| superPowerOf2 | 23       |  5.124 ns | 0.0738 ns | 0.0040 ns |  0.73 |    0.00 |
|               |          |           |           |           |       |         |
| **ipowerOf2**     | **24**       |  **5.104 ns** | **0.0943 ns** | **0.0245 ns** |  **1.08** |    **0.01** |
| fastpowerOf2  | 24       |  4.725 ns | 0.0918 ns | 0.0142 ns |  1.00 |    0.00 |
| superPowerOf2 | 24       |  4.506 ns | 0.1078 ns | 0.0059 ns |  0.95 |    0.00 |
|               |          |           |           |           |       |         |
| **ipowerOf2**     | **25**       |  **5.308 ns** | **0.0039 ns** | **0.0002 ns** |  **0.96** |    **0.00** |
| fastpowerOf2  | 25       |  5.556 ns | 0.0582 ns | 0.0090 ns |  1.00 |    0.00 |
| superPowerOf2 | 25       |  5.788 ns | 0.0627 ns | 0.0034 ns |  1.04 |    0.00 |
|               |          |           |           |           |       |         |
| **ipowerOf2**     | **26**       |  **5.518 ns** | **0.0524 ns** | **0.0029 ns** |  **1.02** |    **0.00** |
| fastpowerOf2  | 26       |  5.384 ns | 0.0743 ns | 0.0193 ns |  1.00 |    0.00 |
| superPowerOf2 | 26       | 10.271 ns | 0.2366 ns | 0.0130 ns |  1.91 |    0.01 |
|               |          |           |           |           |       |         |
| **ipowerOf2**     | **27**       |  **5.757 ns** | **0.0488 ns** | **0.0076 ns** |  **0.77** |    **0.00** |
| fastpowerOf2  | 27       |  7.479 ns | 0.0057 ns | 0.0003 ns |  1.00 |    0.00 |
| superPowerOf2 | 27       |  7.253 ns | 0.3678 ns | 0.0569 ns |  0.97 |    0.01 |
|               |          |           |           |           |       |         |
| **ipowerOf2**     | **28**       |  **6.793 ns** | **0.0957 ns** | **0.0249 ns** |  **1.22** |    **0.00** |
| fastpowerOf2  | 28       |  5.564 ns | 0.0304 ns | 0.0017 ns |  1.00 |    0.00 |
| superPowerOf2 | 28       |  5.771 ns | 0.0175 ns | 0.0010 ns |  1.04 |    0.00 |
|               |          |           |           |           |       |         |
| **ipowerOf2**     | **29**       |  **6.818 ns** | **0.0225 ns** | **0.0012 ns** |  **1.22** |    **0.00** |
| fastpowerOf2  | 29       |  5.577 ns | 0.0261 ns | 0.0014 ns |  1.00 |    0.00 |
| superPowerOf2 | 29       |  7.723 ns | 0.1004 ns | 0.0155 ns |  1.38 |    0.00 |
|               |          |           |           |           |       |         |
| **ipowerOf2**     | **30**       |  **7.109 ns** | **0.2336 ns** | **0.0607 ns** |  **1.42** |    **0.02** |
| fastpowerOf2  | 30       |  5.006 ns | 0.1576 ns | 0.0409 ns |  1.00 |    0.01 |
| superPowerOf2 | 30       |  7.329 ns | 0.0497 ns | 0.0027 ns |  1.46 |    0.01 |
