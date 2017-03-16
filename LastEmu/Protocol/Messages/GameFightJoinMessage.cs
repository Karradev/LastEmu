using Protocol.IO;


using System;

namespace Protocol.Messages
{
	public class GameFightJoinMessage : NetworkMessage
	{
		public const uint Id = 702;

		public bool isTeamPhase;

		public bool canBeCancelled;

		public bool canSayReady;

		public bool isFightStarted;

		public short timeMaxBeforeFightStart;

		public sbyte fightType;

		public override uint ProtocolId
		{
			get
			{
				return (uint)702;
			}
		}

		public GameFightJoinMessage()
		{
		}

		public GameFightJoinMessage(bool isTeamPhase, bool canBeCancelled, bool canSayReady, bool isFightStarted, short timeMaxBeforeFightStart, sbyte fightType)
		{
			this.isTeamPhase = isTeamPhase;
			this.canBeCancelled = canBeCancelled;
			this.canSayReady = canSayReady;
			this.isFightStarted = isFightStarted;
			this.timeMaxBeforeFightStart = timeMaxBeforeFightStart;
			this.fightType = fightType;
		}

		public override void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.isTeamPhase = BooleanByteWrapper.GetFlag(num, 0);
			this.canBeCancelled = BooleanByteWrapper.GetFlag(num, 1);
			this.canSayReady = BooleanByteWrapper.GetFlag(num, 2);
			this.isFightStarted = BooleanByteWrapper.GetFlag(num, 3);
			this.timeMaxBeforeFightStart = reader.ReadShort();
			this.fightType = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.isTeamPhase);
			num = BooleanByteWrapper.SetFlag(num, 1, this.canBeCancelled);
			num = BooleanByteWrapper.SetFlag(num, 2, this.canSayReady);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 3, this.isFightStarted));
			writer.WriteShort(this.timeMaxBeforeFightStart);
			writer.WriteSByte(this.fightType);
		}
	}
}