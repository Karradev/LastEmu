using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class UpdateMapPlayersAgressableStatusMessage : NetworkMessage
	{
		public const uint Id = 6454;

		public double[] playerIds;

		public sbyte[] enable;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6454;
			}
		}

		public UpdateMapPlayersAgressableStatusMessage()
		{
		}

		public UpdateMapPlayersAgressableStatusMessage(double[] playerIds, sbyte[] enable)
		{
			this.playerIds = playerIds;
			this.enable = enable;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.playerIds = new double[num];
			for (int i = 0; i < num; i++)
			{
				this.playerIds[i] = reader.ReadVarUhLong();
			}
			num = (ushort)reader.ReadVarInt();
			this.enable = new sbyte[num];
			for (int j = 0; j < num; j++)
			{
				this.enable[j] = reader.ReadSByte();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.playerIds.Length));
			double[] numArray = this.playerIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarLong(numArray[i]);
			}
			writer.WriteVarInt((int)((int)this.enable.Length));
			sbyte[] numArray1 = this.enable;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteSByte(numArray1[j]);
			}
		}
	}
}