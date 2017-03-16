using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameFightResumeWithSlavesMessage : GameFightResumeMessage
	{
		public const uint Id = 6215;

		public GameFightResumeSlaveInfo[] slavesInfo;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6215;
			}
		}

		public GameFightResumeWithSlavesMessage()
		{
		}

		public GameFightResumeWithSlavesMessage(FightDispellableEffectExtendedInformations[] effects, GameActionMark[] marks, uint gameTurn, int fightStart, Idol[] idols, GameFightSpellCooldown[] spellCooldowns, sbyte summonCount, sbyte bombCount, GameFightResumeSlaveInfo[] slavesInfo) : base(effects, marks, gameTurn, fightStart, idols, spellCooldowns, summonCount, bombCount)
		{
			this.slavesInfo = slavesInfo;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.slavesInfo = new GameFightResumeSlaveInfo[num];
			for (int i = 0; i < num; i++)
			{
				this.slavesInfo[i] = new GameFightResumeSlaveInfo();
				this.slavesInfo[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.slavesInfo.Length));
			GameFightResumeSlaveInfo[] gameFightResumeSlaveInfoArray = this.slavesInfo;
			for (int i = 0; i < (int)gameFightResumeSlaveInfoArray.Length; i++)
			{
				gameFightResumeSlaveInfoArray[i].Serialize(writer);
			}
		}
	}
}