using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class LivingObjectMessageMessage : NetworkMessage
	{
		public const uint Id = 6065;

		public uint msgId;

		public int timeStamp;

		public string owner;

		public uint objectGenericId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6065;
			}
		}

		public LivingObjectMessageMessage()
		{
		}

		public LivingObjectMessageMessage(uint msgId, int timeStamp, string owner, uint objectGenericId)
		{
			this.msgId = msgId;
			this.timeStamp = timeStamp;
			this.owner = owner;
			this.objectGenericId = objectGenericId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.msgId = reader.ReadVarUhShort();
			this.timeStamp = reader.ReadInt();
			this.owner = reader.ReadUTF();
			this.objectGenericId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.msgId);
			writer.WriteInt(this.timeStamp);
			writer.WriteUTF(this.owner);
			writer.WriteVarShort((int)this.objectGenericId);
		}
	}
}