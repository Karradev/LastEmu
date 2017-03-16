using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TeleportDestinationsListMessage : NetworkMessage
	{
		public const uint Id = 5960;

		public sbyte teleporterType;

		public int[] mapIds;

		public uint[] subAreaIds;

		public uint[] costs;

		public sbyte[] destTeleporterType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5960;
			}
		}

		public TeleportDestinationsListMessage()
		{
		}

		public TeleportDestinationsListMessage(sbyte teleporterType, int[] mapIds, uint[] subAreaIds, uint[] costs, sbyte[] destTeleporterType)
		{
			this.teleporterType = teleporterType;
			this.mapIds = mapIds;
			this.subAreaIds = subAreaIds;
			this.costs = costs;
			this.destTeleporterType = destTeleporterType;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.teleporterType = reader.ReadSByte();
			ushort num = reader.ReadUShort();
			this.mapIds = new int[num];
			for (int i = 0; i < num; i++)
			{
				this.mapIds[i] = reader.ReadInt();
			}
			num = reader.ReadUShort();
			this.subAreaIds = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.subAreaIds[j] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.costs = new uint[num];
			for (int k = 0; k < num; k++)
			{
				this.costs[k] = reader.ReadVarUhShort();
			}
			num = (ushort)reader.ReadVarInt();
			this.destTeleporterType = new sbyte[num];
			for (int l = 0; l < num; l++)
			{
				this.destTeleporterType[l] = reader.ReadSByte();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.teleporterType);
			writer.WriteShort((short)((int)this.mapIds.Length));
			int[] numArray = this.mapIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteInt(numArray[i]);
			}
			writer.WriteShort((short)((int)this.subAreaIds.Length));
			uint[] numArray1 = this.subAreaIds;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteVarShort((int)numArray1[j]);
			}
			writer.WriteShort((short)((int)this.costs.Length));
			uint[] numArray2 = this.costs;
			for (int k = 0; k < (int)numArray2.Length; k++)
			{
				writer.WriteVarShort((int)numArray2[k]);
			}
			writer.WriteVarInt((int)((int)this.destTeleporterType.Length));
			sbyte[] numArray3 = this.destTeleporterType;
			for (int l = 0; l < (int)numArray3.Length; l++)
			{
				writer.WriteSByte(numArray3[l]);
			}
		}
	}
}