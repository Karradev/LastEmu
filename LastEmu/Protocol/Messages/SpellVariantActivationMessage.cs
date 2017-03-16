using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SpellVariantActivationMessage : NetworkMessage
	{
		public const uint Id = 6705;

		public bool result;

		public uint activatedSpellId;

		public uint deactivatedSpellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6705;
			}
		}

		public SpellVariantActivationMessage()
		{
		}

		public SpellVariantActivationMessage(bool result, uint activatedSpellId, uint deactivatedSpellId)
		{
			this.result = result;
			this.activatedSpellId = activatedSpellId;
			this.deactivatedSpellId = deactivatedSpellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.result = reader.ReadBoolean();
			this.activatedSpellId = reader.ReadVarUhShort();
			this.deactivatedSpellId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.result);
			writer.WriteVarShort((int)this.activatedSpellId);
			writer.WriteVarShort((int)this.deactivatedSpellId);
		}
	}
}