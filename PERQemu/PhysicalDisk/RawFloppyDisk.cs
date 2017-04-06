// rawfloppydisk.cs - Copyright 2006-2016 Josh Dersch (derschjo@gmail.com)
//
// This file is part of PERQemu.
//
// PERQemu is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// PERQemu is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with PERQemu.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using System.Collections.Generic;
using System.Text;

namespace PERQemu.PhysicalDisk
{
    // Represents a single or double-sided 8" floppy disk in RAW format
    [Serializable]
    public sealed class RawFloppyDisk : PhysicalDisk
    {
        public RawFloppyDisk(DiskGeometry geometry) : base()
        {
            _diskType = geometry;
            CreateSectors();
        }

        public override void Load(System.IO.FileStream fs)
        {
            base.Load(fs);
        }

        public override void ReadHeader(System.IO.FileStream fs)
        {
            // No header info on raw floppy disk images.
        }

        public override void WriteHeader(System.IO.FileStream fs)
        {
            // No header info on raw floppy disk images.
        }
    }
}
