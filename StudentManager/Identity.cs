//  
//  Identity.cs
//  
//  Author:
//       chin <${AuthorEmail}>
// 
//  Copyright (c) 2013 chin
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
using System;

namespace StudentManager
{
    public abstract class Identity: IComparable<Identity>
    {
        public int ID { get; set; }
        
        
        public int CompareTo(Identity other)
        {
            return this.ID - other.ID;
        }
        
        public override bool Equals(Object other)
        {
            if (other == null)
                return false;
            
            Identity _other = other as Identity;
            if (_other == null)
                return false;
            
            return this.ID == _other.ID;
        }
    }
}

