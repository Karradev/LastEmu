using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DareWonListMessage : NetworkMessage
	{
		public const uint Id = 6682;

		public double[] dareId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6682;
			}
		}

		public DareWonListMessage()
		{
		}

		public DareWonListMessage(double[] dareId)
		{
			this.dareId = dareId;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.dareId = new double[num];
			for (int i = 0; i < num; i++)
			{
				this.dareId[i] = reader.ReadDouble();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.dareId.Length));
			double[] numArray = this.dareId;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteDouble(numArray[i]);
			}
		}
	}
}