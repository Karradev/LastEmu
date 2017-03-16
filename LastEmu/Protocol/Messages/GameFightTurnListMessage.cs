using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightTurnListMessage : NetworkMessage
	{
		public const uint Id = 713;

		public double[] ids;

		public double[] deadsIds;

		public override uint ProtocolId
		{
			get
			{
				return (uint)713;
			}
		}

		public GameFightTurnListMessage()
		{
		}

		public GameFightTurnListMessage(double[] ids, double[] deadsIds)
		{
			this.ids = ids;
			this.deadsIds = deadsIds;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.ids = new double[num];
			for (int i = 0; i < num; i++)
			{
				this.ids[i] = reader.ReadDouble();
			}
			num = reader.ReadUShort();
			this.deadsIds = new double[num];
			for (int j = 0; j < num; j++)
			{
				this.deadsIds[j] = reader.ReadDouble();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.ids.Length));
			double[] numArray = this.ids;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteDouble(numArray[i]);
			}
			writer.WriteShort((short)((int)this.deadsIds.Length));
			double[] numArray1 = this.deadsIds;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteDouble(numArray1[j]);
			}
		}
	}
}