using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeMountsStableRemoveMessage : NetworkMessage
	{
		public const uint Id = 6556;

		public int[] mountsId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6556;
			}
		}

		public ExchangeMountsStableRemoveMessage()
		{
		}

		public ExchangeMountsStableRemoveMessage(int[] mountsId)
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