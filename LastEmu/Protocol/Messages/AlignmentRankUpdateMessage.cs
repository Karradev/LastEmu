using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AlignmentRankUpdateMessage : NetworkMessage
	{
		public const uint Id = 6058;

		public sbyte alignmentRank;

		public bool verbose;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6058;
			}
		}

		public AlignmentRankUpdateMessage()
		{
		}

		public AlignmentRankUpdateMessage(sbyte alignmentRank, bool verbose)
		{
			this.alignmentRank = alignmentRank;
			this.verbose = verbose;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.alignmentRank = reader.ReadSByte();
			this.verbose = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.alignmentRank);
			writer.WriteBoolean(this.verbose);
		}
	}
}