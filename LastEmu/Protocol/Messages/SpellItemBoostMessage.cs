using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SpellItemBoostMessage : NetworkMessage
	{
		public const uint Id = 6011;

		public uint statId;

		public uint spellId;

		public int @value;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6011;
			}
		}

		public SpellItemBoostMessage()
		{
		}

		public SpellItemBoostMessage(uint statId, uint spellId, int value)
		{
			this.statId = statId;
			this.spellId = spellId;
			this.@value = value;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.statId = reader.ReadVarUhInt();
			this.spellId = reader.ReadVarUhShort();
			this.@value = reader.ReadVarShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.statId);
			writer.WriteVarShort((int)this.spellId);
			writer.WriteVarShort(this.@value);
		}
	}
}