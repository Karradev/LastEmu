using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class DareCreationRequestMessage : NetworkMessage
	{
		public const uint Id = 6665;

		public bool isPrivate;

		public bool isForGuild;

		public bool isForAlliance;

		public bool needNotifications;

		public int subscriptionFee;

		public int jackpot;

		public ushort maxCountWinners;

		public uint delayBeforeStart;

		public uint duration;

		public DareCriteria[] criterions;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6665;
			}
		}

		public DareCreationRequestMessage()
		{
		}

		public DareCreationRequestMessage(bool isPrivate, bool isForGuild, bool isForAlliance, bool needNotifications, int subscriptionFee, int jackpot, ushort maxCountWinners, uint delayBeforeStart, uint duration, DareCriteria[] criterions)
		{
			this.isPrivate = isPrivate;
			this.isForGuild = isForGuild;
			this.isForAlliance = isForAlliance;
			this.needNotifications = needNotifications;
			this.subscriptionFee = subscriptionFee;
			this.jackpot = jackpot;
			this.maxCountWinners = maxCountWinners;
			this.delayBeforeStart = delayBeforeStart;
			this.duration = duration;
			this.criterions = criterions;
		}

		public override void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.isPrivate = BooleanByteWrapper.GetFlag(num, 0);
			this.isForGuild = BooleanByteWrapper.GetFlag(num, 1);
			this.isForAlliance = BooleanByteWrapper.GetFlag(num, 2);
			this.needNotifications = BooleanByteWrapper.GetFlag(num, 3);
			this.subscriptionFee = reader.ReadInt();
			this.jackpot = reader.ReadInt();
			this.maxCountWinners = reader.ReadUShort();
			this.delayBeforeStart = reader.ReadUInt();
			this.duration = reader.ReadUInt();
			ushort num1 = reader.ReadUShort();
			this.criterions = new DareCriteria[num1];
			for (int i = 0; i < num1; i++)
			{
				this.criterions[i] = new DareCriteria();
				this.criterions[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.isPrivate);
			num = BooleanByteWrapper.SetFlag(num, 1, this.isForGuild);
			num = BooleanByteWrapper.SetFlag(num, 2, this.isForAlliance);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 3, this.needNotifications));
			writer.WriteInt(this.subscriptionFee);
			writer.WriteInt(this.jackpot);
			writer.WriteUShort(this.maxCountWinners);
			writer.WriteUInt(this.delayBeforeStart);
			writer.WriteUInt(this.duration);
			writer.WriteShort((short)((int)this.criterions.Length));
			DareCriteria[] dareCriteriaArray = this.criterions;
			for (int i = 0; i < (int)dareCriteriaArray.Length; i++)
			{
				dareCriteriaArray[i].Serialize(writer);
			}
		}
	}
}