﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Org.Reddragonit.BpmEngine.Interfaces
{
    public interface IElement
    {
        string id { get; }
        XmlNode[] SubNodes { get; }
        string this[string attributeName]{ get; }
        IElement ExtensionElement { get; }
    }
}
