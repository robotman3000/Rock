﻿// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//

namespace Rock.ViewModels.Blocks.Event.RegistrationEntry
{
    /// <summary>
    /// RegistrationEntryBlockSuccessViewModel
    /// </summary>
    public sealed class RegistrationEntrySuccessBag
    {
        /// <summary>
        /// Gets or sets the title HTML.
        /// </summary>
        /// <value>
        /// The title HTML.
        /// </value>
        public string TitleHtml { get; set; }

        /// <summary>
        /// Gets or sets the message HTML.
        /// </summary>
        /// <value>
        /// The message HTML.
        /// </value>
        public string MessageHtml { get; set; }

        /// <summary>
        /// Gets or sets the transaction code.
        /// </summary>
        /// <value>
        /// The transaction code.
        /// </value>
        public string TransactionCode { get; set; }

        /// <summary>
        /// Gets or sets the gateway person identifier.
        /// </summary>
        /// <value>
        /// The gateway person identifier.
        /// </value>
        public string GatewayPersonIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the number of remaining spots for the registration instance.
        /// </summary>
        /// <value>
        /// The number of remaining spots for the registration instance.
        /// </value>
        public int? SpotsRemaining { get; set; }

        /// <summary>
        /// Gets or sets the number of registered registrants in this registration.
        /// </summary>
        /// <value>
        /// The number of registered registrants in this registration.
        /// </value>
        public int RegisteredCount { get; set; }

        /// <summary>
        /// Gets or sets the number of wait-listed registrants in this registration.
        /// </summary>
        /// <value>
        /// The number of wait-listed registrants in this registration.
        /// </value>
        public int WaitListedCount { get; set; }
    }
}
