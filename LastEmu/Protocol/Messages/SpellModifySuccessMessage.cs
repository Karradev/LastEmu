using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SpellModifySuccessMessage : NetworkMessage
	{
		public const uint Id = 6654;

		public int spellId;

		public short spellLevel;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6654;
			}
		}

		public SpellModifySuccessMessage()
		{
		}

		public SpellModifySuccessMessage(int spellId, short spellLevel)
		{
			this.spellId = spellId;
			this.spellLevel = spellLevel;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.spellId = reader.ReadInt();
			this.spellLevel = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.spellId);
			writer.WriteShort(this.spellLevel);
		}
	}
}