using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChallengeTargetsListMessage : NetworkMessage
	{
		public const uint Id = 5613;

		public double[] targetIds;

		public short[] targetCells;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5613;
			}
		}

		public ChallengeTargetsListMessage()
		{
		}

		public ChallengeTargetsListMessage(double[] targetIds, short[] targetCells)
		{
			this.targetIds = targetIds;
			this.targetCells = targetCells;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.targetIds = new double[num];
			for (int i = 0; i < num; i++)
			{
				this.targetIds[i] = reader.ReadDouble();
			}
			num = reader.ReadUShort();
			this.targetCells = new short[num];
			for (int j = 0; j < num; j++)
			{
				this.targetCells[j] = reader.ReadShort();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.targetIds.Length));
			double[] numArray = this.targetIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteDouble(numArray[i]);
			}
			writer.WriteShort((short)((int)this.targetCells.Length));
			short[] numArray1 = this.targetCells;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteShort(numArray1[j]);
			}
		}
	}
}