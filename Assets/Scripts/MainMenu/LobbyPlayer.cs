﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LobbyPlayer : NetworkLobbyPlayer {

	// Use this for initialization
	void Awake () {
        readyToBegin = true;
	}
}
