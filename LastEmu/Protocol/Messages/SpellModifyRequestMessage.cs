using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SpellModifyRequestMessage : NetworkMessage
	{
		public const uint Id = 6655;

		public uint spellId;

		public short spellLevel;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6655;
			}
		}

		public SpellModifyRequestMessage()
		{
		}

		public SpellModifyRequestMessage(uint spellId, short spellLevel)
		{
			this.spellId = spellId;
			this.spellLevel = spellLevel;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.spellId = reader.ReadVarUhShort();
			this.spellLevel = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.spellId);
			writer.WriteShort(this.spellLevel);
		}
	}
}