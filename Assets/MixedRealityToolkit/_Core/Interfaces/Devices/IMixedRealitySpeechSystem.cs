﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace Microsoft.MixedReality.Toolkit.Core.Interfaces.Devices
{
    /// <summary>
    /// Mixed Reality Toolkit controller definition, used to manage a specific controller type
    /// </summary>
    public interface IMixedRealitySpeechSystem : IMixedRealityDeviceManager, IMixedRealityComponent
    {
        /// <summary>
        /// Make sure the keyword recognizer is on, then stop it.
        /// Otherwise, leave it alone because it's already in the desired state.
        /// </summary>
        void StartRecognition();

        /// <summary>
        /// Make sure the keyword recognizer is on, then stop it.
        /// Otherwise, leave it alone because it's already in the desired state.
        /// </summary>
        void StopRecognition();
    }
}