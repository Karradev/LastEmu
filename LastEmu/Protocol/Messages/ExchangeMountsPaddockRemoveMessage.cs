using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeMountsPaddockRemoveMessage : NetworkMessage
	{
		public const uint Id = 6559;

		public int[] mountsId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6559;
			}
		}

		public ExchangeMountsPaddockRemoveMessage()
		{
		}

		public ExchangeMountsPaddockRemoveMessage(int[] mountsId)
		{
			this.mountsId = mountsId;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.mountsId = new int[num];
			for (int i = 0; i < num; i++)
			{
				this.mountsId[i] = reader.ReadVarInt();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.mountsId.Length));
			int[] numArray = this.mountsId;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarInt(numArray[i]);
			}
		}
	}
}