using GTANetworkServer;
using GTANetworkShared;

public class Teleport : Script
{

    [Command("tp")]
    public void tptoplayer(Client sender, Client player)
    {
        if (player.isInVehicle)
        {

            API.sendChatMessageToPlayer(sender, "Teleporting to " + player.name);
            API.setPlayerIntoVehicle(sender, player.vehicle.handle, -2);

        }
        else
        {
            API.sendChatMessageToPlayer(sender, "Teleporting to " + player.name);
            API.setEntityPosition(sender.handle, API.getEntityPosition(player.handle));
        }

    }
}



