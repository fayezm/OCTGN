﻿/* 
 * This file was automatically generated by Jesus!
 * Do not modify, or your sins will be regenerated!!
 * XML: "..\..\Octgn.Library\Scripting\GameEvents.xml"
 *
 * To create the .CS file for this document, 
 * right click the .tt file and click 'Run Custom Tool'
 */
using System;
using System.Collections.Generic;
using Octgn.Play;
using log4net;

namespace Octgn.Scripting
{
	public class GameEventProxy
	{
		internal static ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		private readonly Engine engine;
		private readonly GameEngine gameEngine;
		private readonly Dictionary<string,Octgn.DataNew.Entities.GameEvent[]> eventCache;

		public bool MuteEvents {get;set;}
		public GameEventProxy(Engine scriptEngine, GameEngine gameEngine)
		{
			engine = scriptEngine;
			this.gameEngine = gameEngine;
			eventCache = new Dictionary<string,Octgn.DataNew.Entities.GameEvent[]>();
						eventCache.Add("OnTableLoad",new DataNew.Entities.GameEvent[0]);
			if(gameEngine.Definition.Events.ContainsKey("OnTableLoad"))
				eventCache["OnTableLoad"] = gameEngine.Definition.Events["OnTableLoad"];
								eventCache.Add("OnGameStart",new DataNew.Entities.GameEvent[0]);
			if(gameEngine.Definition.Events.ContainsKey("OnGameStart"))
				eventCache["OnGameStart"] = gameEngine.Definition.Events["OnGameStart"];
								eventCache.Add("OnLoadDeck",new DataNew.Entities.GameEvent[0]);
			if(gameEngine.Definition.Events.ContainsKey("OnLoadDeck"))
				eventCache["OnLoadDeck"] = gameEngine.Definition.Events["OnLoadDeck"];
								eventCache.Add("OnChangeCounter",new DataNew.Entities.GameEvent[0]);
			if(gameEngine.Definition.Events.ContainsKey("OnChangeCounter"))
				eventCache["OnChangeCounter"] = gameEngine.Definition.Events["OnChangeCounter"];
								eventCache.Add("OnEndTurn",new DataNew.Entities.GameEvent[0]);
			if(gameEngine.Definition.Events.ContainsKey("OnEndTurn"))
				eventCache["OnEndTurn"] = gameEngine.Definition.Events["OnEndTurn"];
								eventCache.Add("OnTurn",new DataNew.Entities.GameEvent[0]);
			if(gameEngine.Definition.Events.ContainsKey("OnTurn"))
				eventCache["OnTurn"] = gameEngine.Definition.Events["OnTurn"];
								eventCache.Add("OnTargetCard",new DataNew.Entities.GameEvent[0]);
			if(gameEngine.Definition.Events.ContainsKey("OnTargetCard"))
				eventCache["OnTargetCard"] = gameEngine.Definition.Events["OnTargetCard"];
								eventCache.Add("OnTargetCardArrow",new DataNew.Entities.GameEvent[0]);
			if(gameEngine.Definition.Events.ContainsKey("OnTargetCardArrow"))
				eventCache["OnTargetCardArrow"] = gameEngine.Definition.Events["OnTargetCardArrow"];
								eventCache.Add("OnMoveCard",new DataNew.Entities.GameEvent[0]);
			if(gameEngine.Definition.Events.ContainsKey("OnMoveCard"))
				eventCache["OnMoveCard"] = gameEngine.Definition.Events["OnMoveCard"];
								eventCache.Add("OnPlayerGlobalVariableChanged",new DataNew.Entities.GameEvent[0]);
			if(gameEngine.Definition.Events.ContainsKey("OnPlayerGlobalVariableChanged"))
				eventCache["OnPlayerGlobalVariableChanged"] = gameEngine.Definition.Events["OnPlayerGlobalVariableChanged"];
								eventCache.Add("OnGlobalVariableChanged",new DataNew.Entities.GameEvent[0]);
			if(gameEngine.Definition.Events.ContainsKey("OnGlobalVariableChanged"))
				eventCache["OnGlobalVariableChanged"] = gameEngine.Definition.Events["OnGlobalVariableChanged"];
								eventCache.Add("OnCardClick",new DataNew.Entities.GameEvent[0]);
			if(gameEngine.Definition.Events.ContainsKey("OnCardClick"))
				eventCache["OnCardClick"] = gameEngine.Definition.Events["OnCardClick"];
								eventCache.Add("OnCardDoubleClick",new DataNew.Entities.GameEvent[0]);
			if(gameEngine.Definition.Events.ContainsKey("OnCardDoubleClick"))
				eventCache["OnCardDoubleClick"] = gameEngine.Definition.Events["OnCardDoubleClick"];
								eventCache.Add("OnMarkerChanged",new DataNew.Entities.GameEvent[0]);
			if(gameEngine.Definition.Events.ContainsKey("OnMarkerChanged"))
				eventCache["OnMarkerChanged"] = gameEngine.Definition.Events["OnMarkerChanged"];
								eventCache.Add("OnPlayerConnect",new DataNew.Entities.GameEvent[0]);
			if(gameEngine.Definition.Events.ContainsKey("OnPlayerConnect"))
				eventCache["OnPlayerConnect"] = gameEngine.Definition.Events["OnPlayerConnect"];
								eventCache.Add("OnPlayerRageQuit",new DataNew.Entities.GameEvent[0]);
			if(gameEngine.Definition.Events.ContainsKey("OnPlayerRageQuit"))
				eventCache["OnPlayerRageQuit"] = gameEngine.Definition.Events["OnPlayerRageQuit"];
								eventCache.Add("OnScriptedMoveCard",new DataNew.Entities.GameEvent[0]);
			if(gameEngine.Definition.Events.ContainsKey("OnScriptedMoveCard"))
				eventCache["OnScriptedMoveCard"] = gameEngine.Definition.Events["OnScriptedMoveCard"];
							}
		private static readonly Version C_3_1_0_0 = Version.Parse("3.1.0.0");
		public void OnTableLoad_3_1_0_0()
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_0 )
				return;
			Log.Info("Firing event OnTableLoad_3_1_0_0");
			    
				foreach(var e in eventCache["OnTableLoad"])
				{
					Log.InfoFormat("Firing event OnTableLoad_3_1_0_0 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction);
				}		}
		public void OnGameStart_3_1_0_0()
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_0 )
				return;
			Log.Info("Firing event OnGameStart_3_1_0_0");
			    
				foreach(var e in eventCache["OnGameStart"])
				{
					Log.InfoFormat("Firing event OnGameStart_3_1_0_0 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction);
				}		}
		public void OnLoadDeck_3_1_0_0(Player player, Group[] groups)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_0 )
				return;
			Log.Info("Firing event OnLoadDeck_3_1_0_0");
			var args = new object[2];
			args[0] = player;
			args[1] = groups;
	    
				foreach(var e in eventCache["OnLoadDeck"])
				{
					Log.InfoFormat("Firing event OnLoadDeck_3_1_0_0 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player, groups);
				}		}
		public void OnChangeCounter_3_1_0_0(Player player, Counter counter, int oldValue)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_0 )
				return;
			Log.Info("Firing event OnChangeCounter_3_1_0_0");
			var args = new object[3];
			args[0] = player;
			args[1] = counter;
			args[2] = oldValue;
	    
				foreach(var e in eventCache["OnChangeCounter"])
				{
					Log.InfoFormat("Firing event OnChangeCounter_3_1_0_0 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player, counter, oldValue);
				}		}
		public void OnEndTurn_3_1_0_0(Player player)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_0 )
				return;
			Log.Info("Firing event OnEndTurn_3_1_0_0");
			var args = new object[1];
			args[0] = player;
	    
				foreach(var e in eventCache["OnEndTurn"])
				{
					Log.InfoFormat("Firing event OnEndTurn_3_1_0_0 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player);
				}		}
		public void OnTurn_3_1_0_0(Player player, int turnNumber)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_0 )
				return;
			Log.Info("Firing event OnTurn_3_1_0_0");
			var args = new object[2];
			args[0] = player;
			args[1] = turnNumber;
	    
				foreach(var e in eventCache["OnTurn"])
				{
					Log.InfoFormat("Firing event OnTurn_3_1_0_0 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player, turnNumber);
				}		}
		public void OnTargetCard_3_1_0_0(Player player, Card card, bool isTargeted)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_0 )
				return;
			Log.Info("Firing event OnTargetCard_3_1_0_0");
			var args = new object[3];
			args[0] = player;
			args[1] = card;
			args[2] = isTargeted;
	    
				foreach(var e in eventCache["OnTargetCard"])
				{
					Log.InfoFormat("Firing event OnTargetCard_3_1_0_0 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player, card, isTargeted);
				}		}
		public void OnTargetCardArrow_3_1_0_0(Player player, Card fromCard, Card toCard, bool isTargeted)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_0 )
				return;
			Log.Info("Firing event OnTargetCardArrow_3_1_0_0");
			var args = new object[4];
			args[0] = player;
			args[1] = fromCard;
			args[2] = toCard;
			args[3] = isTargeted;
	    
				foreach(var e in eventCache["OnTargetCardArrow"])
				{
					Log.InfoFormat("Firing event OnTargetCardArrow_3_1_0_0 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player, fromCard, toCard, isTargeted);
				}		}
		public void OnMoveCard_3_1_0_0(Player player, Card card, Group fromGroup, Group toGroup, int oldIndex, int index, int oldX, int oldY, int x, int y, bool isScriptMove)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_0 )
				return;
			Log.Info("Firing event OnMoveCard_3_1_0_0");
			var args = new object[11];
			args[0] = player;
			args[1] = card;
			args[2] = fromGroup;
			args[3] = toGroup;
			args[4] = oldIndex;
			args[5] = index;
			args[6] = oldX;
			args[7] = oldY;
			args[8] = x;
			args[9] = y;
			args[10] = isScriptMove;
	    
				foreach(var e in eventCache["OnMoveCard"])
				{
					Log.InfoFormat("Firing event OnMoveCard_3_1_0_0 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player, card, fromGroup, toGroup, oldIndex, index, oldX, oldY, x, y, isScriptMove);
				}		}
		public void OnPlayerGlobalVariableChanged_3_1_0_0(Player player, string name, string oldValue, string Value)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_0 )
				return;
			Log.Info("Firing event OnPlayerGlobalVariableChanged_3_1_0_0");
			var args = new object[4];
			args[0] = player;
			args[1] = name;
			args[2] = oldValue;
			args[3] = Value;
	    
				foreach(var e in eventCache["OnPlayerGlobalVariableChanged"])
				{
					Log.InfoFormat("Firing event OnPlayerGlobalVariableChanged_3_1_0_0 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player, name, oldValue, Value);
				}		}
		public void OnGlobalVariableChanged_3_1_0_0(string name, string oldValue, string Value)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_0 )
				return;
			Log.Info("Firing event OnGlobalVariableChanged_3_1_0_0");
			var args = new object[3];
			args[0] = name;
			args[1] = oldValue;
			args[2] = Value;
	    
				foreach(var e in eventCache["OnGlobalVariableChanged"])
				{
					Log.InfoFormat("Firing event OnGlobalVariableChanged_3_1_0_0 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,name, oldValue, Value);
				}		}
		public void OnCardClick_3_1_0_0(Card card, int mouseButton, string[] keysDown)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_0 )
				return;
			Log.Info("Firing event OnCardClick_3_1_0_0");
			var args = new object[3];
			args[0] = card;
			args[1] = mouseButton;
			args[2] = keysDown;
	    
				foreach(var e in eventCache["OnCardClick"])
				{
					Log.InfoFormat("Firing event OnCardClick_3_1_0_0 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,card, mouseButton, keysDown);
				}		}
		public void OnCardDoubleClick_3_1_0_0(Card card, int mouseButton, string[] keysDown)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_0 )
				return;
			Log.Info("Firing event OnCardDoubleClick_3_1_0_0");
			var args = new object[3];
			args[0] = card;
			args[1] = mouseButton;
			args[2] = keysDown;
	    
				foreach(var e in eventCache["OnCardDoubleClick"])
				{
					Log.InfoFormat("Firing event OnCardDoubleClick_3_1_0_0 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,card, mouseButton, keysDown);
				}		}
		public void OnMarkerChanged_3_1_0_0(Card card, string markerName, int oldValue, int newValue, bool isScriptChange)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_0 )
				return;
			Log.Info("Firing event OnMarkerChanged_3_1_0_0");
			var args = new object[5];
			args[0] = card;
			args[1] = markerName;
			args[2] = oldValue;
			args[3] = newValue;
			args[4] = isScriptChange;
	    
				foreach(var e in eventCache["OnMarkerChanged"])
				{
					Log.InfoFormat("Firing event OnMarkerChanged_3_1_0_0 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,card, markerName, oldValue, newValue, isScriptChange);
				}		}
	private static readonly Version C_3_1_0_1 = Version.Parse("3.1.0.1");
		public void OnTableLoad_3_1_0_1()
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_1 )
				return;
			Log.Info("Firing event OnTableLoad_3_1_0_1");
			    
				foreach(var e in eventCache["OnTableLoad"])
				{
					Log.InfoFormat("Firing event OnTableLoad_3_1_0_1 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction);
				}		}
		public void OnGameStart_3_1_0_1()
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_1 )
				return;
			Log.Info("Firing event OnGameStart_3_1_0_1");
			    
				foreach(var e in eventCache["OnGameStart"])
				{
					Log.InfoFormat("Firing event OnGameStart_3_1_0_1 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction);
				}		}
		public void OnPlayerConnect_3_1_0_1(Player player)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_1 )
				return;
			Log.Info("Firing event OnPlayerConnect_3_1_0_1");
			var args = new object[1];
			args[0] = player;
	    
				foreach(var e in eventCache["OnPlayerConnect"])
				{
					Log.InfoFormat("Firing event OnPlayerConnect_3_1_0_1 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player);
				}		}
		public void OnPlayerRageQuit_3_1_0_1(Player player)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_1 )
				return;
			Log.Info("Firing event OnPlayerRageQuit_3_1_0_1");
			var args = new object[1];
			args[0] = player;
	    
				foreach(var e in eventCache["OnPlayerRageQuit"])
				{
					Log.InfoFormat("Firing event OnPlayerRageQuit_3_1_0_1 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player);
				}		}
		public void OnLoadDeck_3_1_0_1(Player player, Group[] groups)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_1 )
				return;
			Log.Info("Firing event OnLoadDeck_3_1_0_1");
			var args = new object[2];
			args[0] = player;
			args[1] = groups;
	    
				foreach(var e in eventCache["OnLoadDeck"])
				{
					Log.InfoFormat("Firing event OnLoadDeck_3_1_0_1 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player, groups);
				}		}
		public void OnChangeCounter_3_1_0_1(Player player, Counter counter, int oldValue)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_1 )
				return;
			Log.Info("Firing event OnChangeCounter_3_1_0_1");
			var args = new object[3];
			args[0] = player;
			args[1] = counter;
			args[2] = oldValue;
	    
				foreach(var e in eventCache["OnChangeCounter"])
				{
					Log.InfoFormat("Firing event OnChangeCounter_3_1_0_1 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player, counter, oldValue);
				}		}
		public void OnEndTurn_3_1_0_1(Player player)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_1 )
				return;
			Log.Info("Firing event OnEndTurn_3_1_0_1");
			var args = new object[1];
			args[0] = player;
	    
				foreach(var e in eventCache["OnEndTurn"])
				{
					Log.InfoFormat("Firing event OnEndTurn_3_1_0_1 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player);
				}		}
		public void OnTurn_3_1_0_1(Player player, int turnNumber)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_1 )
				return;
			Log.Info("Firing event OnTurn_3_1_0_1");
			var args = new object[2];
			args[0] = player;
			args[1] = turnNumber;
	    
				foreach(var e in eventCache["OnTurn"])
				{
					Log.InfoFormat("Firing event OnTurn_3_1_0_1 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player, turnNumber);
				}		}
		public void OnTargetCard_3_1_0_1(Player player, Card card, bool isTargeted)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_1 )
				return;
			Log.Info("Firing event OnTargetCard_3_1_0_1");
			var args = new object[3];
			args[0] = player;
			args[1] = card;
			args[2] = isTargeted;
	    
				foreach(var e in eventCache["OnTargetCard"])
				{
					Log.InfoFormat("Firing event OnTargetCard_3_1_0_1 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player, card, isTargeted);
				}		}
		public void OnTargetCardArrow_3_1_0_1(Player player, Card fromCard, Card toCard, bool isTargeted)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_1 )
				return;
			Log.Info("Firing event OnTargetCardArrow_3_1_0_1");
			var args = new object[4];
			args[0] = player;
			args[1] = fromCard;
			args[2] = toCard;
			args[3] = isTargeted;
	    
				foreach(var e in eventCache["OnTargetCardArrow"])
				{
					Log.InfoFormat("Firing event OnTargetCardArrow_3_1_0_1 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player, fromCard, toCard, isTargeted);
				}		}
		public void OnPlayerGlobalVariableChanged_3_1_0_1(Player player, string name, string oldValue, string Value)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_1 )
				return;
			Log.Info("Firing event OnPlayerGlobalVariableChanged_3_1_0_1");
			var args = new object[4];
			args[0] = player;
			args[1] = name;
			args[2] = oldValue;
			args[3] = Value;
	    
				foreach(var e in eventCache["OnPlayerGlobalVariableChanged"])
				{
					Log.InfoFormat("Firing event OnPlayerGlobalVariableChanged_3_1_0_1 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player, name, oldValue, Value);
				}		}
		public void OnGlobalVariableChanged_3_1_0_1(string name, string oldValue, string Value)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_1 )
				return;
			Log.Info("Firing event OnGlobalVariableChanged_3_1_0_1");
			var args = new object[3];
			args[0] = name;
			args[1] = oldValue;
			args[2] = Value;
	    
				foreach(var e in eventCache["OnGlobalVariableChanged"])
				{
					Log.InfoFormat("Firing event OnGlobalVariableChanged_3_1_0_1 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,name, oldValue, Value);
				}		}
		public void OnCardClick_3_1_0_1(Card card, int mouseButton, string[] keysDown)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_1 )
				return;
			Log.Info("Firing event OnCardClick_3_1_0_1");
			var args = new object[3];
			args[0] = card;
			args[1] = mouseButton;
			args[2] = keysDown;
	    
				foreach(var e in eventCache["OnCardClick"])
				{
					Log.InfoFormat("Firing event OnCardClick_3_1_0_1 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,card, mouseButton, keysDown);
				}		}
		public void OnCardDoubleClick_3_1_0_1(Card card, int mouseButton, string[] keysDown)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_1 )
				return;
			Log.Info("Firing event OnCardDoubleClick_3_1_0_1");
			var args = new object[3];
			args[0] = card;
			args[1] = mouseButton;
			args[2] = keysDown;
	    
				foreach(var e in eventCache["OnCardDoubleClick"])
				{
					Log.InfoFormat("Firing event OnCardDoubleClick_3_1_0_1 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,card, mouseButton, keysDown);
				}		}
		public void OnMarkerChanged_3_1_0_1(Card card, string markerName, int oldValue, int newValue, bool isScriptChange)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_1 )
				return;
			Log.Info("Firing event OnMarkerChanged_3_1_0_1");
			var args = new object[5];
			args[0] = card;
			args[1] = markerName;
			args[2] = oldValue;
			args[3] = newValue;
			args[4] = isScriptChange;
	    
				foreach(var e in eventCache["OnMarkerChanged"])
				{
					Log.InfoFormat("Firing event OnMarkerChanged_3_1_0_1 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,card, markerName, oldValue, newValue, isScriptChange);
				}		}
		public void OnMoveCard_3_1_0_1(Player player, Card card, Group fromGroup, Group toGroup, int oldIndex, int index, int oldX, int oldY, int x, int y, bool isScriptMove, string highlight, string markers)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_1 )
				return;
			Log.Info("Firing event OnMoveCard_3_1_0_1");
			var args = new object[13];
			args[0] = player;
			args[1] = card;
			args[2] = fromGroup;
			args[3] = toGroup;
			args[4] = oldIndex;
			args[5] = index;
			args[6] = oldX;
			args[7] = oldY;
			args[8] = x;
			args[9] = y;
			args[10] = isScriptMove;
			args[11] = highlight;
			args[12] = markers;
	    
				foreach(var e in eventCache["OnMoveCard"])
				{
					Log.InfoFormat("Firing event OnMoveCard_3_1_0_1 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player, card, fromGroup, toGroup, oldIndex, index, oldX, oldY, x, y, isScriptMove, highlight, markers);
				}		}
		public void OnScriptedMoveCard_3_1_0_1(Player player, Card card, Group fromGroup, Group toGroup, int oldIndex, int index, int oldX, int oldY, int x, int y, bool isScriptMove, string highlight, string markers)
		{
			if(Player.LocalPlayer.Spectator)return;
			if(MuteEvents)return;
			if(gameEngine.Definition.ScriptVersion != C_3_1_0_1 )
				return;
			Log.Info("Firing event OnScriptedMoveCard_3_1_0_1");
			var args = new object[13];
			args[0] = player;
			args[1] = card;
			args[2] = fromGroup;
			args[3] = toGroup;
			args[4] = oldIndex;
			args[5] = index;
			args[6] = oldX;
			args[7] = oldY;
			args[8] = x;
			args[9] = y;
			args[10] = isScriptMove;
			args[11] = highlight;
			args[12] = markers;
	    
				foreach(var e in eventCache["OnScriptedMoveCard"])
				{
					Log.InfoFormat("Firing event OnScriptedMoveCard_3_1_0_1 -> {0}",e.Name);
					engine.ExecuteFunction(e.PythonFunction,player, card, fromGroup, toGroup, oldIndex, index, oldX, oldY, x, y, isScriptMove, highlight, markers);
				}		}
	}
}
