﻿namespace PandocNet;

public class PhpMdExtraIn :
    InOptions
{
    public PhpMdExtraIn(Stream stream) :
        base(stream)
    {
    }

    public PhpMdExtraIn(string file) :
        base(file)
    {
    }

    public override string Format => "markdown_phpextra";
    //https://pandoc.org/MANUAL.html#reader-options
    public string? DefaultImageExtension { get; set; }

    public override IEnumerable<string> GetArguments()
    {
        foreach (var argument in base.GetArguments())
        {
            yield return argument;
        }

        if (DefaultImageExtension != null)
        {
            yield return $"--default-image-extension={DefaultImageExtension}";
        }
    }
}