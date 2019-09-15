﻿using System;
using System.Collections.Generic;
using System.Linq;
using DeftHack.Attributes;
using DeftHack.Options;
using DeftHack.Variables;
using UnityEngine;

namespace DeftHack.Utilities
{
	// Token: 0x02000015 RID: 21
	public static class HotkeyUtilities
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00004FFC File Offset: 0x000031FC
		[Initializer]
		public static void Initialize()
		{
			HotkeyUtilities.AddHotkey("АИМБОТ", "Аимбот On/Off", "_ToggleAimbot", new KeyCode[]
			{
				KeyCode.Keypad3
			});
			HotkeyUtilities.AddHotkey("АИМБОТ", "Аимбот по кнопке On/Off", "_AimbotOnKey", new KeyCode[]
			{
				KeyCode.Keypad4
			});
			HotkeyUtilities.AddHotkey("АИМБОТ", "Кнопка Аимбота", "_AimbotKey", new KeyCode[]
			{
				KeyCode.F
			});
			HotkeyUtilities.AddHotkey("ОРУЖИЕ", "Триггербот On/Off", "_ToggleTriggerbot", new KeyCode[]
			{
				KeyCode.Keypad5
			});
			HotkeyUtilities.AddHotkey("ОРУЖИЕ", "Без отдачи On/Off", "_ToggleNoRecoil", new KeyCode[]
			{
				KeyCode.Keypad6
			});
			HotkeyUtilities.AddHotkey("ОРУЖИЕ", "Без разброса On/Off", "_ToggleNoSpread", new KeyCode[]
			{
				KeyCode.Keypad7
			});
			HotkeyUtilities.AddHotkey("ОРУЖИЕ", "Без увода On/Off", "_ToggleNoSway", new KeyCode[]
			{
				KeyCode.Keypad8
			});
			HotkeyUtilities.AddHotkey("Полёт Машины", "Полёт машины On/Off", "_VFToggle", new KeyCode[]
			{
				KeyCode.Slash
			});
			HotkeyUtilities.AddHotkey("Полёт Машины", "Вверх", "_VFStrafeUp", new KeyCode[]
			{
				KeyCode.RightControl
			});
			HotkeyUtilities.AddHotkey("Полёт Машины", "Вниз", "_VFStrafeDown", new KeyCode[]
			{
				KeyCode.LeftControl
			});
			HotkeyUtilities.AddHotkey("Полёт Машины", "Влево", "_VFStrafeLeft", new KeyCode[]
			{
				KeyCode.LeftBracket
			});
			HotkeyUtilities.AddHotkey("Полёт Машины", "Вправо", "_VFStrafeRight", new KeyCode[]
			{
				KeyCode.RightBracket
			});
			HotkeyUtilities.AddHotkey("Полёт Машины", "Движение вперёд", "_VFMoveForward", new KeyCode[]
			{
				KeyCode.W
			});
			HotkeyUtilities.AddHotkey("Полёт Машины", "Движение назад", "_VFMoveBackward", new KeyCode[]
			{
				KeyCode.S
			});
			HotkeyUtilities.AddHotkey("Полёт Машины", "Поворот налево", "_VFRotateLeft", new KeyCode[]
			{
				KeyCode.A
			});
			HotkeyUtilities.AddHotkey("Полёт Машины", "Поворот направо", "_VFRotateRight", new KeyCode[]
			{
				KeyCode.D
			});
			HotkeyUtilities.AddHotkey("Полёт Машины", "Поворот вверх", "_VFRotateUp", new KeyCode[]
			{
				KeyCode.Space
			});
			HotkeyUtilities.AddHotkey("Полёт Машины", "Поворот вниз", "_VFRotateDown", new KeyCode[]
			{
				KeyCode.LeftShift
			});
			HotkeyUtilities.AddHotkey("Полёт Машины", "Вращаться влево", "_VFRollLeft", new KeyCode[]
			{
				KeyCode.Q
			});
			HotkeyUtilities.AddHotkey("Полёт Машины", "Вращаться вправо", "_VFRollRight", new KeyCode[]
			{
				KeyCode.E
			});
			HotkeyUtilities.AddHotkey("Полёт игрока", "Вверх", "_FlyUp", new KeyCode[]
			{
				KeyCode.Space
			});
			HotkeyUtilities.AddHotkey("Полёт игрока", "Вниз", "_FlyDown", new KeyCode[]
			{
				KeyCode.LeftControl
			});
			HotkeyUtilities.AddHotkey("Полёт игрока", "Влево", "_FlyLeft", new KeyCode[]
			{
				KeyCode.A
			});
			HotkeyUtilities.AddHotkey("Полёт игрока", "Вправо", "_FlyRight", new KeyCode[]
			{
				KeyCode.D
			});
			HotkeyUtilities.AddHotkey("Полёт игрока", "Движение вперёд", "_FlyForward", new KeyCode[]
			{
				KeyCode.W
			});
			HotkeyUtilities.AddHotkey("Полёт игрока", "Движение назад", "_FlyBackward", new KeyCode[]
			{
				KeyCode.S
			});
			HotkeyUtilities.AddHotkey("Прочее", "Паник-кей", "_PanicButton", new KeyCode[]
			{
				KeyCode.Keypad0
			});
			HotkeyUtilities.AddHotkey("Прочее", "Свободная камера On/Off", "_ToggleFreecam", new KeyCode[]
			{
				KeyCode.Keypad2
			});
			HotkeyUtilities.AddHotkey("Прочее", "Выбор игрока", "_SelectPlayer", new KeyCode[]
			{
				KeyCode.LeftAlt
			});
			HotkeyUtilities.AddHotkey("Прочее", "Мгновенное отключение", "_InstantDisconnect", new KeyCode[]
			{
				KeyCode.F5
			});
			HotkeyUtilities.AddHotkey("Прочее", "Авто подбор вещей", "_AutoPickUp", new KeyCode[]
			{
				KeyCode.Mouse2
			});
			HotkeyUtilities.AddHotkey("Прочее", "Команда 1", "_Com1", new KeyCode[]
			{
				KeyCode.F8
			});
			HotkeyUtilities.AddHotkey("Прочее", "Команда 2", "_Com2", new KeyCode[]
			{
				KeyCode.F9
			});
			HotkeyUtilities.AddHotkey("Прочее", "Команда 3", "_Com3", new KeyCode[]
			{
				KeyCode.F10
			});
			HotkeyUtilities.AddHotkey("Прочее", "Команда 4", "_Com4", new KeyCode[]
			{
				KeyCode.F11
			});
			HotkeyUtilities.AddHotkey("Прочее", "Команда 5", "_Com5", new KeyCode[]
			{
				KeyCode.F12
			});
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000054C8 File Offset: 0x000036C8
		public static void AddHotkey(string Group, string Name, string Identifier, params KeyCode[] DefaultKeys)
		{
			bool flag = !HotkeyOptions.HotkeyDict.ContainsKey(Group);
			if (flag)
			{
				HotkeyOptions.HotkeyDict.Add(Group, new Dictionary<string, Hotkey>());
			}
			Dictionary<string, Hotkey> dictionary = HotkeyOptions.HotkeyDict[Group];
			bool flag2 = dictionary.ContainsKey(Identifier);
			if (!flag2)
			{
				Hotkey value = new Hotkey
				{
					Name = Name,
					Keys = DefaultKeys
				};
				dictionary.Add(Identifier, value);
				HotkeyOptions.UnorganizedHotkeys.Add(Identifier, value);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00005540 File Offset: 0x00003740
		public static bool IsHotkeyDown(string Identifier)
		{
			return HotkeyOptions.UnorganizedHotkeys[Identifier].Keys.Any(new Func<KeyCode, bool>(Input.GetKeyDown)) && HotkeyOptions.UnorganizedHotkeys[Identifier].Keys.All(new Func<KeyCode, bool>(Input.GetKey));
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000559C File Offset: 0x0000379C
		public static bool IsHotkeyHeld(string Identifier)
		{
			return HotkeyOptions.UnorganizedHotkeys[Identifier].Keys.All(new Func<KeyCode, bool>(Input.GetKey));
		}
	}
}
