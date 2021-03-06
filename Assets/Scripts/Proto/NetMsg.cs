/**
 * Tool generation, do not modify!!!
 */

using System;
using Base.Debug;
using Base.Utils;
using System.Collections.Generic;

public class NetMsg
{
	public const int LOGIN = 1001;
	//=============================================================================
	private static Dictionary<int, Type> MsgIdTypeDict;

	public static void Init()
	{
		MsgIdTypeDict = new Dictionary<int, Type>();
		MsgIdTypeDict.Add(LOGIN, typeof(User.LoginResponse));
	}

	public static Type GetTypeByMsgId(int msgId)
	{
		if (MsgIdTypeDict == null) Init();
		if (MsgIdTypeDict.ContainsKey(msgId))
		{
			return MsgIdTypeDict[msgId];
		}
		Debugger.LogError(StringUtil.Concat("Not Find Msg Type! Error MsgId: ", msgId));
		return null;
	}
}
