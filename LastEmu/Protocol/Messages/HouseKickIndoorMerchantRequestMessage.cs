using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class HouseKickIndoorMerchantRequestMessage : NetworkMessage
	{
		public const uint Id = 5661;

		public uint cellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5661;
			}
		}

		public HouseKickIndoorMerchantRequestMessage()
		{
		}

		public HouseKickIndoorMerchantRequestMessage(uint cellId)
		{
			this.cellId = cellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.cellId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.cellId);
		}
	}
}