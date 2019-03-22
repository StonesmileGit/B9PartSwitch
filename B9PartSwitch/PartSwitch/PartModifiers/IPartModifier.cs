﻿using System;

namespace B9PartSwitch.PartSwitch.PartModifiers
{
    public interface IPartModifier
    {
        object PartAspectLock { get; }
        string Description { get; }

        void DeactivateOnStartEditor();
        void DeactivateOnStartFlight();
        void ActivateOnStartEditor();
        void ActivateOnStartFlight();
        void ActivateAfterStart();
        void DeactivateOnSwitchEditor();
        void DeactivateOnSwitchFlight();
        void ActivateOnSwitchEditor();
        void ActivateOnSwitchFlight();
        void OnIconCreateInactiveSubtype();
        void OnIconCreateActiveSubtype();
        void UpdateVolumeEditor();
        void UpdateVolumeFlight();
        void OnWillBeCopiedActiveSubtype();
        void OnWillBeCopiedInactiveSubtype();
        void OnWasCopiedActiveSubtype();
        void OnWasCopiedInactiveSubtype();
        void OnBeforeReinitialize();
    }
}
