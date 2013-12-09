﻿/*
 
    LibertyV - Viewer/Editor for RAGE Package File version 7
    Copyright (C) 2013  koolk <koolkdev at gmail.com>
   
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.
  
    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.
   
    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibertyV.Rage.Resources.Types.Game.rage
{
    class pgDictionary : TemplateClassTypeInfo
    {
        // TODO: I should wrap clases like that (With user-friendly interface and usage)
        protected pgDictionary(TypeInfo templateItem)
            : base("rage::pgDictionary", templateItem)
        {
            base.AddMember("base", Game.rage.pgBase.TypeInfo);
            base.AddMember("UnknownZero", Basic.UInteger32.TypeInfo);
            base.AddMember("UseCount", Basic.UInteger32.TypeInfo);
            base.AddMember("NameHashes", Basic.List.GetTemplateClassTypeInfo<Basic.List>(Basic.UInteger32.TypeInfo));
            base.AddMember("Entries", Basic.List.GetTemplateClassTypeInfo<Basic.List>(templateItem));
        }
    }
}
