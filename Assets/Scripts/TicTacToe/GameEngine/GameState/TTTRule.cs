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
using UnityEngine;
using System.Collections;
using System;

public class TTTRule : Rule {

    public delegate bool Applicator(TTTGameState state, GameEvent eve, TTTGameEngine engine);
    public delegate bool MenuApplicator(TTTMenuState state, GameEvent eve, TTTMenuEngine engine);
    public Applicator apllicator;
    public MenuApplicator menuApllicator;

    public TTTRule(string category, Applicator applier) : base(category) {
        apllicator = applier;
    }
    public TTTRule(string category, MenuApplicator applier)
        : base(category) {
            menuApllicator = applier;
    }

    public override bool applyTo(GameState state, GameEvent eve, GameEngine engine) {
        throw new ArgumentException("Invalid game state type! Expected a TTTGameState, got " + state.GetType().ToString());
    }

    public bool applyTo(TTTGameState state, GameEvent eve, TTTGameEngine engine) {
        return apllicator(state, eve, engine);
    }
    public bool applyTo(TTTMenuState state, GameEvent eve, TTTMenuEngine engine) {
        return menuApllicator(state, eve, engine);
    }
	
}