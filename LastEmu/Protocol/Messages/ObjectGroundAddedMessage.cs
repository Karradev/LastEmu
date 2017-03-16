using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectGroundAddedMessage : NetworkMessage
	{
		public const uint Id = 3017;

		public uint cellId;

		public uint objectGID;

		public override uint ProtocolId
		{
			get
			{
				return (uint)3017;
			}
		}

		public ObjectGroundAddedMessage()
		{
		}

		public ObjectGroundAddedMessage(uint cellId, uint objectGID)
		{
			this.cellId = cellId;
			this.objectGID = objectGID;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.cellId = reader.ReadVarUhShort();
			this.objectGID = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.cellId);
			writer.WriteVarShort((int)this.objectGID);
		}
	}
}