using Interactables.Interobjects.DoorButtons;
using Interactables.Interobjects.DoorUtils;
using LabApi.Events.Arguments.PlayerEvents;
using LabApi.Events.CustomHandlers;
using LabApi.Features.Console;
using LabApi.Features.Wrappers;

#nullable enable
namespace RemoteKeycard
{
    public class KeycardEventHandler : CustomEventsHandler
    {
        
        public override void OnPlayerInteractingDoor(PlayerInteractingDoorEventArgs ev)
        {
            Logger.Debug("InteractingDoorEvent is Running!");

            if (ev.Player.IsBypassEnabled)
            {
                ev.CanOpen = true;
            }

            if (ev.Player.RoleBase is IDoorPermissionProvider roleProvider &&
                ev.Door.Base.PermissionsPolicy.CheckPermissions(roleProvider.GetPermissions(ev.Door.Base)))
            {
                ev.CanOpen = true;
            }
            
            foreach (Item? item in ev.Player.Items)
            {
                if (item?.Base is IDoorPermissionProvider itemProvider &&
                    ev.Door.Base.PermissionsPolicy.CheckPermissions(itemProvider.GetPermissions(ev.Door.Base)))
                {
                    ev.CanOpen = true;
                }
            }
        }

        public override void OnPlayerInteractingLocker(PlayerInteractingLockerEventArgs ev)
        {
                foreach (Item? item in ev.Player.Items)
                {
                    if (item?.Base is IDoorPermissionProvider itemProvider && ev.Locker.Base.PermissionsPolicy.CheckPermissions(itemProvider.GetPermissions(pedestal.Chamber.Base)))
                    {
                        ev.CanOpen = true;
                    }
                    
                }
            }
        
        }
        
    }
}