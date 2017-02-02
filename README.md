# tptoplayer
Basic script for teleporting to other players

#Installation

put the folder in your resources folder.

This script is also available as a snippet 

```
    [Command("tp")]
    public void tptoplayer(Client sender,Client player)
    {
        if (player.isInVehicle) { 

            API.sendChatMessageToPlayer(sender, "~h~~b~Teleporting to " + player.name);
            API.setPlayerIntoVehicle(sender, player.vehicle.handle, -2);

        }
        else
        {
            API.sendChatMessageToPlayer(sender, "~h~~b~Teleporting to " + player.name);
            API.setEntityPosition(sender.handle, API.getEntityPosition(player.handle));
        }

    }
    
   ```
