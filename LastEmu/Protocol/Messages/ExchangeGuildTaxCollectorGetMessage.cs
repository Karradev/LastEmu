using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeGuildTaxCollectorGetMessage : NetworkMessage
	{
		public const uint Id = 5762;

		public string collectorName;

		public short worldX;

		public short worldY;

		public int mapId;

		public uint subAreaId;

		public string userName;

		public double callerId;

		public string callerName;

		public double experience;

		public uint pods;

		public ObjectItemGenericQuantity[] objectsInfos;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5762;
			}
		}

		public ExchangeGuildTaxCollectorGetMessage()
		{
		}

		public ExchangeGuildTaxCollectorGetMessage(string collectorName, short worldX, short worldY, int mapId, uint subAreaId, string userName, double callerId, string callerName, double experience, uint pods, ObjectItemGenericQuantity[] objectsInfos)
		{
			this.collectorName = collectorName;
			this.worldX = worldX;
			this.worldY = worldY;
			this.mapId = mapId;
			this.subAreaId = subAreaId;
			this.userName = userName;
			this.callerId = callerId;
			this.callerName = callerName;
			this.experience = experience;
			this.pods = pods;
			this.objectsInfos = objectsInfos;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.collectorName = reader.ReadUTF();
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.mapId = reader.ReadInt();
			this.subAreaId = reader.ReadVarUhShort();
			this.userName = reader.ReadUTF();
			this.callerId = reader.ReadVarUhLong();
			this.callerName = reader.ReadUTF();
			this.experience = reader.ReadDouble();
			this.pods = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.objectsInfos = new ObjectItemGenericQuantity[num];
			for (int i = 0; i < num; i++)
			{
				this.objectsInfos[i] = new ObjectItemGenericQuantity();
				this.objectsInfos[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.collectorName);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteInt(this.mapId);
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteUTF(this.userName);
			writer.WriteVarLong(this.callerId);
			writer.WriteUTF(this.callerName);
			writer.WriteDouble(this.experience);
			writer.WriteVarShort((int)this.pods);
			writer.WriteShort((short)((int)this.objectsInfos.Length));
			ObjectItemGenericQuantity[] objectItemGenericQuantityArray = this.objectsInfos;
			for (int i = 0; i < (int)objectItemGenericQuantityArray.Length; i++)
			{
				objectItemGenericQuantityArray[i].Serialize(writer);
			}
		}
	}
}