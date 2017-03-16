using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class IdolPartyLostMessage : NetworkMessage
	{
		public const uint Id = 6580;

		public uint idolId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6580;
			}
		}

		public IdolPartyLostMessage()
		{
		}

		public IdolPartyLostMessage(uint idolId)
		{
			this.idolId = idolId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.idolId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.idolId);
		}
	}
}