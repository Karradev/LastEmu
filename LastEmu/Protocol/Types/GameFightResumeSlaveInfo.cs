using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameFightResumeSlaveInfo
	{
		public const short Id = 364;

		public double slaveId;

		public GameFightSpellCooldown[] spellCooldowns;

		public sbyte summonCount;

		public sbyte bombCount;

		public virtual short TypeId
		{
			get
			{
				return 364;
			}
		}

		public GameFightResumeSlaveInfo()
		{
		}

		public GameFightResumeSlaveInfo(double slaveId, GameFightSpellCooldown[] spellCooldowns, sbyte summonCount, sbyte bombCount)
		{
			this.slaveId = slaveId;
			this.spellCooldowns = spellCooldowns;
			this.summonCount = summonCount;
			this.bombCount = bombCount;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.slaveId = reader.ReadDouble();
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

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.slaveId);
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