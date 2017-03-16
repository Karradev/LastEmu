using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PrismFightRemovedMessage : NetworkMessage
	{
		public const uint Id = 6453;

		public uint subAreaId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6453;
			}
		}

		public PrismFightRemovedMessage()
		{
		}

		public PrismFightRemovedMessage(uint subAreaId)
		{
			this.subAreaId = subAreaId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.subAreaId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.subAreaId);
		}
	}
}