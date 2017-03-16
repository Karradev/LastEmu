using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class GameFightSpellCooldown
	{
		public const short Id = 205;

		public int spellId;

		public sbyte cooldown;

		public virtual short TypeId
		{
			get
			{
				return 205;
			}
		}

		public GameFightSpellCooldown()
		{
		}

		public GameFightSpellCooldown(int spellId, sbyte cooldown)
		{
			this.spellId = spellId;
			this.cooldown = cooldown;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.spellId = reader.ReadInt();
			this.cooldown = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.spellId);
			writer.WriteSByte(this.cooldown);
		}
	}
}