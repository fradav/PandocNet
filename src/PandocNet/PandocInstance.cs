﻿namespace Pandoc;

public static class PandocInstance
{
    static PandocEngine instance = new();

    public static void SetPandocPath(string pandocPath)
    {
        instance.pandocPath = pandocPath;
    }

    public static Task<StringResult> ConvertToText<TIn, TOut>(
        string content,
        TIn? inOptions = null,
        TOut? outOptions = null,
        Options? options = null,
        CancellationToken cancellation = default)
        where TIn : InOptions, new()
        where TOut : OutOptions, new()
    {
        return instance.ConvertToText(content, inOptions, outOptions, options, cancellation);
    }

    public static Task<Result> Convert<TIn, TOut>(
        Input input,
        Output output,
        TIn? inOptions = null,
        TOut? outOptions = null,
        Options? options = null,
        CancellationToken cancellation = default)
        where TIn : InOptions, new()
        where TOut : OutOptions, new()
    {
        return instance.Convert(input, output, inOptions, outOptions, options, cancellation);
    }
}