//
// Encog(tm) Core v3.3 - .Net Version
// http://www.heatonresearch.com/encog/
//
// Copyright 2008-2014 Heaton Research, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//   
// For more information on Heaton Research copyrights, licenses 
// and trademarks visit:
// http://www.heatonresearch.com/copyright
//
using System;

namespace Encog.App.Analyst
{
    /// <summary>
    ///     An error has occured with the Encog Analyst.
    /// </summary>
    [Serializable]
    public class AnalystError : EncogError
    {
        /// <summary>
        ///     Construct a message exception.
        /// </summary>
        /// <param name="msg">The exception message.</param>
        public AnalystError(String msg) : base(msg)
        {
        }

        /// <summary>
        ///     Construct an exception that holds another exception.
        /// </summary>
        /// <param name="t">The other exception.</param>
        public AnalystError(Exception t) : base(t)
        {
        }
    }
}
