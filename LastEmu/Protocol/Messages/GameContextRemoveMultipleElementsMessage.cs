using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameContextRemoveMultipleElementsMessage : NetworkMessage
	{
		public const uint Id = 252;

		public double[] id;

		public override uint ProtocolId
		{
			get
			{
				return (uint)252;
			}
		}

		public GameContextRemoveMultipleElementsMessage()
		{
		}

		public GameContextRemoveMultipleElementsMessage(double[] id)
		{
			this.id = id;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.id = new double[num];
			for (int i = 0; i < num; i++)
			{
				this.id[i] = reader.ReadDouble();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.id.Length));
			double[] numArray = this.id;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteDouble(numArray[i]);
			}
		}
	}
}