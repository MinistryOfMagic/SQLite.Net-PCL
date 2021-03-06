//
// Copyright (c) 2012 Krueger Systems, Inc.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using JetBrains.Annotations;

namespace SQLite.Net.Interop
{
    [PublicAPI]
    [Flags]
    public enum CreateFlags
    {
        None = 0x000,
        ImplicitPK = 0x001, // create a primary key for field called 'Id' (Orm.ImplicitPkName)
        ImplicitIndex = 0x002, // create an index for fields ending in 'Id' (Orm.ImplicitIndexSuffix)
        AllImplicit = 0x003, // do both above
        AutoIncPK = 0x004, // force PK field to be auto inc
        FullTextSearch3 = 0x100, // create virtual table using FTS3
        FullTextSearch4 = 0x200 // create virtual table using FTS4
    }
}