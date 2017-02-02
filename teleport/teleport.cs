using GTANetworkServer;
using GTANetworkShared;

public class Teleport : Script
{

    [Command("tp")]
    public void tptoplayer(Client sender, Client player)
    {
        if (player.isInVehicle)
        {
            API.setPlayerIntoVehicle(sender, player.vehicle.handle, -2);
        }
        else
        {
            API.setEntityPosition(sender.handle, API.getEntityPosition(player.handle));
        }
        
        API.sendChatMessageToPlayer(sender, "Teleporting to " + player.name);
    }
}



