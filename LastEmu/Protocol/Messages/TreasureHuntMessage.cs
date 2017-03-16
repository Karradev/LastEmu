using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class TreasureHuntMessage : NetworkMessage
	{
		public const uint Id = 6486;

		public sbyte questType;

		public int startMapId;

		public TreasureHuntStep[] knownStepsList;

		public sbyte totalStepCount;

		public uint checkPointCurrent;

		public uint checkPointTotal;

		public int availableRetryCount;

		public TreasureHuntFlag[] flags;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6486;
			}
		}

		public TreasureHuntMessage()
		{
		}

		public TreasureHuntMessage(sbyte questType, int startMapId, TreasureHuntStep[] knownStepsList, sbyte totalStepCount, uint checkPointCurrent, uint checkPointTotal, int availableRetryCount, TreasureHuntFlag[] flags)
		{
			this.questType = questType;
			this.startMapId = startMapId;
			this.knownStepsList = knownStepsList;
			this.totalStepCount = totalStepCount;
			this.checkPointCurrent = checkPointCurrent;
			this.checkPointTotal = checkPointTotal;
			this.availableRetryCount = availableRetryCount;
			this.flags = flags;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.questType = reader.ReadSByte();
			this.startMapId = reader.ReadInt();
			ushort num = reader.ReadUShort();
			this.knownStepsList = new TreasureHuntStep[num];
			for (int i = 0; i < num; i++)
			{
				this.knownStepsList[i] = ProtocolTypeManager.GetInstance<TreasureHuntStep>(reader.ReadUShort());
				this.knownStepsList[i].Deserialize(reader);
			}
			this.totalStepCount = reader.ReadSByte();
			this.checkPointCurrent = reader.ReadVarUhInt();
			this.checkPointTotal = reader.ReadVarUhInt();
			this.availableRetryCount = reader.ReadInt();
			num = reader.ReadUShort();
			this.flags = new TreasureHuntFlag[num];
			for (int j = 0; j < num; j++)
			{
				this.flags[j] = new TreasureHuntFlag();
				this.flags[j].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.questType);
			writer.WriteInt(this.startMapId);
			writer.WriteShort((short)((int)this.knownStepsList.Length));
			TreasureHuntStep[] treasureHuntStepArray = this.knownStepsList;
			for (int i = 0; i < (int)treasureHuntStepArray.Length; i++)
			{
				TreasureHuntStep treasureHuntStep = treasureHuntStepArray[i];
				writer.WriteShort(treasureHuntStep.TypeId);
				treasureHuntStep.Serialize(writer);
			}
			writer.WriteSByte(this.totalStepCount);
			writer.WriteVarInt((int)this.checkPointCurrent);
			writer.WriteVarInt((int)this.checkPointTotal);
			writer.WriteInt(this.availableRetryCount);
			writer.WriteShort((short)((int)this.flags.Length));
			TreasureHuntFlag[] treasureHuntFlagArray = this.flags;
			for (int j = 0; j < (int)treasureHuntFlagArray.Length; j++)
			{
				treasureHuntFlagArray[j].Serialize(writer);
			}
		}
	}
}