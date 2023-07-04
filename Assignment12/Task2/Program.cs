using BenchmarkDotNet.Running;
using System.Collections;
using Task2;

BenchmarkRunner.Run(typeof(Benchmark).Assembly);
