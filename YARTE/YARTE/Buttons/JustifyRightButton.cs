﻿using System.Drawing;
using YARTE.Properties;

namespace YARTE.UI.Buttons
{
    public class JustifyRightButton : IHTMLEditorButton
    {
        public void IconClicked(HTMLEditorButtonArgs args)
        {
            args.Document.ExecCommand(CommandIdentifier, false, null);
        }

        public Image IconImage
        {
            get { return Resources.justifyright; }
        }

        public string IconName
        {
            get { return "Justify right"; }
        }

        public string IconTooltip
        {
            get { return "Justify right"; }
        }

        public string CommandIdentifier
        {
            get { return "JustifyRight"; }
        }
    }
}