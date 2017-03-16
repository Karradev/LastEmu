using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AllianceInsiderPrismInformation : PrismInformation
	{
		public const short Id = 431;

		public int lastTimeSlotModificationDate;

		public uint lastTimeSlotModificationAuthorGuildId;

		public double lastTimeSlotModificationAuthorId;

		public string lastTimeSlotModificationAuthorName;

		public ObjectItem[] modulesObjects;

		public override short TypeId
		{
			get
			{
				return 431;
			}
		}

		public AllianceInsiderPrismInformation()
		{
		}

		public AllianceInsiderPrismInformation(sbyte typeId, sbyte state, int nextVulnerabilityDate, int placementDate, uint rewardTokenCount, int lastTimeSlotModificationDate, uint lastTimeSlotModificationAuthorGuildId, double lastTimeSlotModificationAuthorId, string lastTimeSlotModificationAuthorName, ObjectItem[] modulesObjects) : base(typeId, state, nextVulnerabilityDate, placementDate, rewardTokenCount)
		{
			this.lastTimeSlotModificationDate = lastTimeSlotModificationDate;
			this.lastTimeSlotModificationAuthorGuildId = lastTimeSlotModificationAuthorGuildId;
			this.lastTimeSlotModificationAuthorId = lastTimeSlotModificationAuthorId;
			this.lastTimeSlotModificationAuthorName = lastTimeSlotModificationAuthorName;
			this.modulesObjects = modulesObjects;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.lastTimeSlotModificationDate = reader.ReadInt();
			this.lastTimeSlotModificationAuthorGuildId = reader.ReadVarUhInt();
			this.lastTimeSlotModificationAuthorId = reader.ReadVarUhLong();
			this.lastTimeSlotModificationAuthorName = reader.ReadUTF();
			ushort num = reader.ReadUShort();
			this.modulesObjects = new ObjectItem[num];
			for (int i = 0; i < num; i++)
			{
				this.modulesObjects[i] = new ObjectItem();
				this.modulesObjects[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.lastTimeSlotModificationDate);
			writer.WriteVarInt((int)this.lastTimeSlotModificationAuthorGuildId);
			writer.WriteVarLong(this.lastTimeSlotModificationAuthorId);
			writer.WriteUTF(this.lastTimeSlotModificationAuthorName);
			writer.WriteShort((short)((int)this.modulesObjects.Length));
			ObjectItem[] objectItemArray = this.modulesObjects;
			for (int i = 0; i < (int)objectItemArray.Length; i++)
			{
				objectItemArray[i].Serialize(writer);
			}
		}
	}
}