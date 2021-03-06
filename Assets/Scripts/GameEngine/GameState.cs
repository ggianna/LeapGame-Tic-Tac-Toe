﻿
/**
 * Copyright 2016 , SciFY NPO - http://www.scify.org
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
/**
 * The file for the GameState class. 
 * 
 * This file holds the definition and implementation 
 * of GameState class. This file is part of
 * the LEAP project. 
 * 
 * @file GameState.cs
 * @version 1.0
 * @date 14/01/2015 (dd/mm/yyyy)
 * @author Nick Zorbas
 * @copyright SciFY distributed as is under Apache v2 License.
 */
using UnityEngine;
using System.Collections.Generic;
using System;

[Serializable]
public class GameState {

	public long timestamp;
	public List<Actor> actors;
	public List<Player> players;
	public List<WorldObject> environment;
    public int curPlayer;
    public GameResult result;

	public GameState() {
		timestamp = 0;
	}
}