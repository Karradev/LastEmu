using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameFightTurnResumeMessage : GameFightTurnStartMessage
	{
		public const uint Id = 6307;

		public uint remainingTime;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6307;
			}
		}

		public GameFightTurnResumeMessage()
		{
		}

		public GameFightTurnResumeMessage(double id, uint waitTime, uint remainingTime) : base(id, waitTime)
		{
			this.remainingTime = remainingTime;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.remainingTime = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.remainingTime);
		}
	}
}