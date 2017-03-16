using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SpellVariantActivationRequestMessage : NetworkMessage
	{
		public const uint Id = 6707;

		public uint spellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6707;
			}
		}

		public SpellVariantActivationRequestMessage()
		{
		}

		public SpellVariantActivationRequestMessage(uint spellId)
		{
			this.spellId = spellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.spellId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.spellId);
		}
	}
}