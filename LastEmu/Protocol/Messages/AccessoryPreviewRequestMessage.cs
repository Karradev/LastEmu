using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AccessoryPreviewRequestMessage : NetworkMessage
	{
		public const uint Id = 6518;

		public uint[] genericId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6518;
			}
		}

		public AccessoryPreviewRequestMessage()
		{
		}

		public AccessoryPreviewRequestMessage(uint[] genericId)
		{
			this.genericId = genericId;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.genericId = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.genericId[i] = reader.ReadVarUhShort();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.genericId.Length));
			uint[] numArray = this.genericId;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
		}
	}
}