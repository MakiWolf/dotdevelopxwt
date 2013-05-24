// 
// IWidgetSurface.cs
//  
// Author:
//       Lluis Sanchez <lluis@xamarin.com>
// 
// Copyright (c) 2011 Xamarin Inc
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

using System;
using System.Collections.Generic;


namespace Xwt
{
	public interface IWidgetSurface
	{
		void Reallocate ();
		
		/// <summary>
		/// Gets the preferred size of the widget (includes the margin)
		/// </summary>
		/// <returns>
		/// The preferred size.
		/// </returns>
		/// <remarks>
		/// The returned size is >= 0. If a constraint is specified, the returned size will not
		/// be bigger than the constraint.
		/// </remarks>
		Size GetPreferredSize (SizeContraint widthConstraint, SizeContraint heightConstraint);
		
		/// <summary>
		/// Gets the preferred size of the widget (includes the margin)
		/// </summary>
		/// <returns>
		/// The preferred size.
		/// </returns>
		/// <remarks>
		/// The returned size is >= 0
		/// </remarks>
		Size GetPreferredSize ();

		object NativeWidget { get; }

		IEnumerable<Widget> Children { get; }

		Toolkit ToolkitEngine { get; }
	}
}

