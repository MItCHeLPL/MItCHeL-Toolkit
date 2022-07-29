using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public static class PhotonUtils
{
	//CUSTOM RPC
	public static void InterestRPCAll(GameObject gameObject, string methodName, byte[] interestGroups, params object[] parameters)
	{
		PhotonView photonView = gameObject.GetComponent<PhotonView>();

		InterestRPCAll(photonView, methodName, interestGroups, parameters);
	}
	public static void InterestRPCAll(PhotonView photonView, string methodName, byte[] interestGroups, params object[] parameters)
	{
		foreach (Player player in PhotonNetwork.PlayerList)
		{
			InterestRPC(photonView, methodName, player, interestGroups, parameters);
		}
	}

	public static void InterestRPC(GameObject gameObject, string methodName, Player targetPlayer, byte[] interestGroups, params object[] parameters)
	{
		PhotonView photonView = gameObject.GetComponent<PhotonView>();

		InterestRPC(photonView, methodName, targetPlayer, interestGroups, parameters);
	}
	public static void InterestRPC(PhotonView photonView, string methodName, Player targetPlayer, byte[] interestGroups, params object[] parameters)
	{
		foreach (byte interestGroup in interestGroups)
		{
			if (PartyManager.IsPlayerInGroup(targetPlayer, interestGroup))
			{
				photonView.RPC(methodName, targetPlayer, parameters);
				break;
			}
		}
	}

	//GAMEOBJECT AND PLAYER
	public static Player GameObjectToPlayer(GameObject gameObject)
	{
		foreach(Player player in PhotonNetwork.PlayerList)
		{
			if(PlayerToGameObject(player) == gameObject)
			{
				return player;
			}
		}

		return null;
	}
	public static GameObject PlayerToGameObject(Player player)
	{
		if(player.TagObject != null)
        {
			return (GameObject)player.TagObject;
		}
		else
        {
			return null;
        }
	}

	//ID
	public static Player PlayerFromUserID(string playerID)
	{
		return Array.Find(PhotonNetwork.PlayerList, el => el.UserId == playerID);
	}
	public static string[] PlayerListToIDArray(List<Player> players)
	{
		string[] ids = new string[players.Count];

		for(int i=0; i< players.Count; i++)
        {
			ids[i] = players[i].UserId;
        }

		return ids;
	}
}
