using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameFightResumeMessage : GameFightSpectateMessage
	{
		public const uint Id = 6067;

		public GameFightSpellCooldown[] spellCooldowns;

		public sbyte summonCount;

		public sbyte bombCount;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6067;
			}
		}

		public GameFightResumeMessage()
		{
		}

		public GameFightResumeMessage(FightDispellableEffectExtendedInformations[] effects, GameActionMark[] marks, uint gameTurn, int fightStart, Idol[] idols, GameFightSpellCooldown[] spellCooldowns, sbyte summonCount, sbyte bombCount) : base(effects, marks, gameTurn, fightStart, idols)
		{
			this.spellCooldowns = spellCooldowns;
			this.summonCount = summonCount;
			this.bombCount = bombCount;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.spellCooldowns = new GameFightSpellCooldown[num];
			for (int i = 0; i < num; i++)
			{
				this.spellCooldowns[i] = new GameFightSpellCooldown();
				this.spellCooldowns[i].Deserialize(reader);
			}
			this.summonCount = reader.ReadSByte();
			this.bombCount = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.spellCooldowns.Length));
			GameFightSpellCooldown[] gameFightSpellCooldownArray = this.spellCooldowns;
			for (int i = 0; i < (int)gameFightSpellCooldownArray.Length; i++)
			{
				gameFightSpellCooldownArray[i].Serialize(writer);
			}
			writer.WriteSByte(this.summonCount);
			writer.WriteSByte(this.bombCount);
		}
	}
}