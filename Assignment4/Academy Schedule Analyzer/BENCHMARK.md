# Benchmark Analysis

## Benchmark Results

The benchmark was executed on my own machine using BenchmarkDotNet.

| Method | Iterations | Mean | Allocated |
|---|---:|---:|---:|
| StringConcatenation | 100 | 14.640 us | 81.21 KB |
| StringBuilderConcatenation | 100 | 1.894 us | 4.98 KB |
| StringConcatenation | 1000 | 1,220.013 us | 7843.71 KB |
| StringBuilderConcatenation | 1000 | 8.553 us | 33.75 KB |
| StringConcatenation | 10000 | 215,831.038 us | 781621.2 KB |
| StringBuilderConcatenation | 10000 | 232.529 us | 312.25 KB |
| StringConcatenation | 100000 | 33,110,870.153 us | 78132882.16 KB |
| StringBuilderConcatenation | 100000 | 2,188.208 us | 3123.23 KB |

## Analysis

### 1. Which approach was faster with 100 iterations?

StringBuilder was faster.

String concatenation had a mean of 14.640 us, while StringBuilder had a mean of 1.894 us.

### 2. Which approach was faster with 100,000 iterations?

StringBuilder was faster.

String concatenation had a mean of 33,110,870.153 us, while StringBuilder had a mean of 2,188.208 us.

### 3. Which approach allocated more memory?

String concatenation allocated significantly more memory than StringBuilder.

At 100,000 iterations, String concatenation allocated about 78 GB, while StringBuilder allocated about 3.12 MB.

### 4. What happened to string concatenation performance as the loop size increased?

String concatenation became dramatically slower as the number of iterations increased.

Its mean increased from 14.640 us at 100 iterations to 33,110,870.153 us at 100,000 iterations.

### 5. Why does repeated string concatenation create additional allocations?

Strings are immutable in C#. Each concatenation creates a new string containing the updated result instead of modifying the existing string.

Therefore, repeated concatenation creates many temporary string objects and additional memory allocations.

### 6. Why does StringBuilder usually perform better when text is repeatedly appended?

StringBuilder uses a mutable buffer that can be expanded as needed.

It can append text without creating a new string for every append operation, which usually reduces allocations and improves performance for repeated appends.

### 7. Is StringBuilder always better than normal string operations? Explain.

No.

For a small number of simple concatenations, normal string operations can be convenient and may have good performance.

StringBuilder is more useful when a large amount of text is repeatedly appended or modified.